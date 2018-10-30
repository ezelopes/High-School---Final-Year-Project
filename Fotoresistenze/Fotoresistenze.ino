#include <Ethernet.h>
#include <SPI.h>

byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };
byte server[] = { 192, 168, 1, 3 };
//byte server[] = { 172, 22, 20, 179 };
EthernetClient client;

int sensor = 4;

void setup()
{
  Serial.begin(9600);
  pinMode(sensor, INPUT);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
   Serial.print("Serial OK");
   Serial.println();
   
  // start the Ethernet connection:
  if (Ethernet.begin(mac) == 0) {
    Serial.println("Failed to configure Ethernet using DHCP");
    // no point in carrying on, so do nothing forevermore:
    for (;;)
      ;
  }
  
  Serial.print("My IP address: ");
  for (byte thisByte = 0; thisByte < 4; thisByte++) 
  {
    Serial.print(Ethernet.localIP()[thisByte], DEC);
    Serial.print(".");
  } 

  delay(1000);

  Serial.println("connecting...");
  
  if (client.connect(server, 9000))
  {
    Serial.println("connected");
  } 
  else 
  {
    Serial.println("connection failed");
  }
}

void loop()
{
  int sensorState = digitalRead(sensor);
  
  String msg = String(sensorState);
      
  if(msg=="0")
  {
    Serial.println(msg);
    byte bytes[msg.length() + 1];
    msg.getBytes(bytes, msg.length() + 1);

    int len_bytes = sizeof(bytes);
    client.write(bytes, len_bytes);

    delay(1000);
  }

  
  
}
