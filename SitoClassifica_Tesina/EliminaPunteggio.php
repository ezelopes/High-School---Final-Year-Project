
<?php
session_start();

$connection = new mysqli("127.0.0.1", "root", "", "basketapp");

if($connection->connect_error)
{
    die("connessione fallita".$connection->connect_error);
}

if(isset($_POST['ID']))
{
    foreach($_POST['ID'] as $id) 
    {
        $query = "DELETE FROM punteggio
        WHERE ID = '".$id."'";

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