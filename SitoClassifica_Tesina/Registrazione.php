<?php
if(isset($_SESSION['Username'])){
header("location: Benvenuto.php");
}
?>
<html>
<head>
<title> Bask-Tech Registrati! </title>
<link rel="icon" href="LogoBasket2.png" />
<link href="style.css" rel="stylesheet" type="text/css">
<link rel="stylesheet" href="bootstrap/css/bootstrap.css">
<script src="//code.jquery.com/jquery-1.9.1.min.js"></script>
<link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900|RobotoDraft:400,100,300,500,700,900'>
<link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
<link id="bsdp-css" href="bootstrap-datepicker-1.6.1-dist/css/bootstrap-datepicker3.css" rel="stylesheet">

<script rel="text/javascript" src="bootstrap-datepicker-1.6.1-dist/js/bootstrap-datepicker.min.js"></script>
<script type="text/javascript">
    $(document).ready(function ($) {
        $('#datetimepicker').datepicker({
            format: "yyyy-mm-dd"
        });
    });
</script> <!--calendario-->
    


</head>
<body>
<div class="container">
    <div class="card"></div>
    <div class="card">
        <h1 class="title">Registrati!</h1>
        <form action="<?php echo $_SERVER["PHP_SELF"]?>" method="post">
        <div class="input-container">
            <input type="text" id="Username" name="Username" required="required"/>
            <label for="Username">Username</label>
            <div class="bar"></div>
        </div>
        <div class="input-container">
            <input type="text" id="Nome" name="Nome" required="required"/>
            <label for="Nome">Nome</label>
            <div class="bar"></div>
        </div>
        <div class="input-container">
            <input type="text" id="Cognome" name="Cognome" required="required"/>
            <label for="Cognome">Cognome</label>
            <div class="bar"></div>
        </div>
        <div class="input-container">
            
            
        <div class='input-group date' id='datetimepicker'>                            
            <input type='text' name="DataNascita" class="form-control" placeholder="Data di nascita" style = 'color: black;'/>
            </div>
 
      
        
 
        </div>
      <!--
      -->
      <div class="input-container">
        <input type="text" id="Paese" name="Paese" required="required"/>
        <label for="Paese">Paese</label>
        <div class="bar"></div>
      </div>
      <div class="input-container">
        <input type="password" id="Password" name = "Password" required="required"/>
        <label for="Password">Password</label>
        <div class="bar"></div>
      </div>
      <div class="button-container">
        <button name= "submit"><span>Go</span></button>
      </div>
      </form>
<?php
//session_start(); // Starting Session
$error=''; // Variable To Store Error Message
if (isset($_POST['submit'])) 
{
    if (empty($_POST['Username']) || empty($_POST['Password']) || empty($_POST['Nome']) || empty($_POST['Cognome'])) 
    {
        $error = "Username or Password is invalid";
    }
    else
    {
    
        $username=$_POST['Username'];
        $password= hash("sha256",$_POST['Password']);
        $nome=$_POST['Nome'];
        $cognome = $_POST['Cognome'];
        $paese = $_POST['Paese'];
        $datanascita = $_POST['DataNascita'];
        
        $connection = new mysqli("localhost", "root", "", "basketapp");
        
    /*  $username= stripslashes($username);
        $password= stripslashes($password);
        $nome= stripslashes($nome);
        $cognome = stripslashes($cognome);
        $paese = stripslashes($paese);
        $datanascita = stripslashes($datanascita);*/
        
        if ($connection->connect_error) 
        {
            die("Tentativo di connessione fallita: " . $connection->connect_error);
        }

        $sql="INSERT INTO `giocatore`(`Username`, `Nome`, `Cognome`, `DataNascita`, `Paese`) 
        VALUES ('".$username."','".$nome."', '".$cognome."', '".$datanascita."', '".$paese."')";
    
        $result = $connection->query($sql);

        if($result == TRUE && $connection->affected_rows == 1)
        {
            $sql="INSERT INTO `login`(`FK_Username`, `Psw`) 
            VALUES ('".$username."','".$password."')";
            
            $result2 = $connection->query($sql);
            
            if($result == TRUE && $connection->affected_rows == 1)
            {
                session_start();
                $sql="SELECT * FROM login WHERE Psw='".$password."' AND FK_Username='".$username."'";
                $result3 = $connection->query($sql);
                $row = $result3->fetch_assoc();  
                $_SESSION['Username']=$row['FK_Username'];
                $_SESSION['Ruolo']=$row['Ruolo'];
                header("location: Benvenuto.php");                
            }
        }
        else
        {
            $error = "Controlla i campi!";
            echo "<script type='text/javascript'>alert('$error');</script>";
                //echo "mysql error: {$connection->error}";
        }
        
        $connection->close();
    }
}
?>
  </div>
</div>
</body>
</html>