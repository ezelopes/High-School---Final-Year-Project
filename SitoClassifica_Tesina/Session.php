<?php
// Establishing Connection with Server by passing server_name, user_id and password as a parameter
$connection = new mysqli("localhost", "root", "", "basketapp");
session_start();// Starting Session
// Storing Session
$user_check=$_SESSION['Username'];
$rule_check=$_SESSION['Ruolo'];
// SQL Query To Fetch Complete Information Of User
if ($connection->connect_error) 
{
    die("Tentativo di connessione fallita: " . $connection->connect_error);
}

$sql = "SELECT login.FK_Username, login.Ruolo FROM login WHERE FK_Username='".$user_check."' AND Ruolo='". $rule_check ."' ";
$result = $connection->query($sql);

$row = $result->fetch_assoc();
$user_session =$row['FK_Username'];
$ruolo_session =$row['Ruolo'];
if(!isset($user_session))
{
    $connection->close(); // Closing Connection
   // session_unset();
   // session_destroy();
    header('Location: Accedi.php'); // Redirecting To Home Page
}
?>