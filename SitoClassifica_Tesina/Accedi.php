<?php
session_start();
if(isset($_SESSION['Username'])){
header("location: Benvenuto.php");
}
?>
<!DOCTYPE html>
<html>
<head>
<title> Accedi! </title>
<link rel="icon" href="logo.jpg" />
<link href="style.css" rel="stylesheet" type="text/css">
<link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900|RobotoDraft:400,100,300,500,700,900'>
<link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
</head>
<body>
<div class="container">
  <div class="card"></div>
  <div class="card">
      <div id="logo"><img src = "logo.jpg"></div>
    <h1 class="title">Accedi!</h1>
    <form action="<?php echo $_SERVER["PHP_SELF"]?>" method="post">
      <div class="input-container">
        <input type="text" id="Username" name="Username" required="required"/>
        <label for="Username">Username</label>
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
    <a class="registration" href="Registrazione.php">Non hai ancora un account? Registrati! </a><br><br>
    </form>
<?php
$error=''; // Variable To Store Error Message
if (isset($_POST['submit'])) 
{
    if (empty($_POST['Username']) || empty($_POST['Password'])) 
    {
        $error = "Username or Password is invalid";
    }
    else
    {
    
        $username=$_POST['Username'];
        $password=$_POST['Password'];
        
        $connection = new mysqli("localhost", "root", "", "basketapp");
        
    /*  $username= stripslashes($username);
        $password= stripslashes($password);*/
        
        if ($connection->connect_error) 
        {
            die("Tentativo di connessione fallita: " . $connection->connect_error);
        }

        $sql="SELECT * FROM login WHERE Psw='".$password."' AND FK_Username='".$username."'";
    
        $result = $connection->query($sql);

        if($result == TRUE && $connection->affected_rows == 1)
        {
            $row = $result->fetch_assoc();  
            $_SESSION['Username']=$row['FK_Username'];
            $_SESSION['Ruolo']=$row['Ruolo'];
                        
            header("location: Benvenuto.php");         
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