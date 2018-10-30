<?php
session_start();
if(session_destroy()) // Destroying All Sessions
{
header("Location: Accedi.php"); // Redirecting To Home Page
}
?>