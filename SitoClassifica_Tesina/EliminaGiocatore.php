
<?php
session_start();

$connection = new mysqli("127.0.0.1", "root", "", "basketapp");

if($connection->connect_error)
{
    die("connessione fallita".$connection->connect_error);
}

if(isset($_POST['Username']))
{
    foreach($_POST['Username'] as $username) 
    {
        $query = "DELETE FROM punteggio
        WHERE FK_Username = '".$username."'";

        $del= $connection->query($query);
    }

    if (!$del)
    {
	   die("Errore nella query $query: " . mysql_error());
    }
    
    foreach($_POST['Username'] as $username) 
    {
    $query = "DELETE FROM login
    WHERE FK_Username = '".$username."' AND Ruolo = 'Giocatore'";
    
    $del= $connection->query($query);
    }
    if (!$del)
    {
	   die("Errore nella query $query: " . mysql_error());
    }
    
    foreach($_POST['Username'] as $username) 
    {
    $query = "DELETE FROM giocatore
    WHERE Username = '".$username."'";
    
    $del= $connection->query($query);
    }
    if (!$del)
    {
	   die("Errore nella query $query: " . mysql_error());
    }
}
//else
//{    
//    $message = "Seleziona qualcosa!";
//    echo "<script type='text/javascript'>alert('$message');</script>";   
//    header("Location: VisualizzaCanzonePlaylist.php?NomePlaylist=".$NomePlaylist.""); 
//}


    header("Location: Benvenuto.php");  
     

$connection->close();

?>