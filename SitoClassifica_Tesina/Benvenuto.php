
<?php
include('Session.php');
?>
<!DOCTYPE html>
<html>
<head>  
    <title> Bask-Tech </title>  
    <link rel="icon" href="LogoBasket2.png" />
    
    <meta charset="UTF-8">
    
    <link rel="shortcut icon" href="http://d15dxvojnvxp1x.cloudfront.net/assets/favicon.ico">
    <link rel="icon" href="http://d15dxvojnvxp1x.cloudfront.net/assets/favicon.ico">
    
    <!-- CSS -->
    <link rel="stylesheet" type="text/css" media="all" href="css/styles.css">
    
    <!-- TABLE SORTER -->
    <script type="text/javascript" src="js/jquery-1.10.2.min.js"></script>
    <script type="text/javascript" src="js/jquery.tablesorter.min.js"></script>
    
    <!-- GOOGLE API -->
    <link href='https://fonts.googleapis.com/css?family=Amaranth' rel='stylesheet' type='text/css'>
    <link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900|RobotoDraft:400,100,300,500,700,900'>
    
    <!-- BOOTSTRAP -->
    <script src="//code.jquery.com/jquery-1.9.1.min.js"></script>
    <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
    <style type="text/css"> .bs-example{ margin: 20px; } </style>
</head>

<body>
    
 <!--   <ul>
        <li><a class="active" href="#">Home</a></li>
        <li><a href="#">Visualizza</a></li>
        <li><a href="#">Contatti</a></li>
        <li style="float:right; background-color: #5f74a0;"><a class="logout" href="Logout.php">Log Out</a></li>
    </ul>
  -->
<!--
<div id="menu">  
<ul>
    <li><a class="active" href="#home">Home</a></li>
    <li class="dropdown">
        <a href="#" class="dropbtn">Visualizza</a>
        <div class="dropdown-content">
            <a href="TuoiPunteggi.php">I tuoi Punteggi</a>
            <a href="PunteggiPaese.php">Punteggi per Paese</a>
            <a href="PunteggiData.php">Punteggi per Data Partita</a>
        </div>
    </li>
    <li><a href="#news">Contatti</a></li>
    <li style="float:right; background-color: #5f74a0;"><a class="logout" href="Logout.php">Log Out</a></li>
</ul>
</div>
-->
<nav role="navigation" class="navbar navbar-inverse">
<!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
        <button type="button" data-target="#navbarCollapse" data-toggle="collapse" class="navbar-toggle">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
        </button>
        <a href="#" class="navbar-brand">Bask-Tech</a>
    </div>
<!-- Collection of nav links, forms, and other content for toggling -->
    
    <?php 
    echo "<div id='navbarCollapse' class='collapse navbar-collapse'>";
    if($ruolo_session == 'Giocatore')
    {
        echo
            "
                <ul class='nav navbar-nav'>
                    <li class='active'><a href='Benvenuto.php'>Home</a></li>
                    <li class='dropdown' >
                    <a data-toggle='dropdown' class='dropdown-toggle' href='#'>Visualizza<b class='caret'></b></a>
                        <ul role='menu' class='dropdown-menu'>
                            <li><a href='TuoiPunteggi.php'>I Tuoi Punteggi</a></li>
                            <li><a href='PunteggiPaese.php'>Punteggi per Paese</a></li>
                            <li><a href='PunteggiData.php'>Punteggi per Data Partita</a></li>
                        </ul>
                    </li>
                </ul>
            ";
    }
    else if($ruolo_session == 'Admin')
    {
        echo 
            "
            <ul class='nav navbar-nav'>
                    <li class='active'><a href='Benvenuto.php'>Home</a></li>
            </ul>
            ";
    }
    echo 
        " 
        
        <ul class='nav navbar-nav navbar-right'>
            <li><a href='Logout.php'>Logout</a></li>
        </ul>
    </div>
        ";
    ?>
    
    
</nav>   
    
    
<br><br>
    <div id="wrapper">
        
  <?php
    $message = "";
    $connection = new mysqli("localhost", "root", "", "basketapp");
    $error = 'FALSE';
    if ($connection->connect_error) {
        die("Connessione fallita: " . $connection->connect_error);
        $error = TRUE;
        $message = "wrong answer";
        echo "<script type='text/javascript'>alert('$message');</script>";
        $connection->close();
    }
    if ($error == 'FALSE')
    {
        
            $sql = "SELECT punteggio.FK_Username as Nome, punteggio.Punti as Punti, punteggio.DataPartita as DataPartita, punteggio.ID as ID
            FROM punteggio
            ORDER BY punteggio.Punti desc";
            $result = $connection->query($sql);
            
            echo 
                "
                <h1 style='color: #5f74a0; font-family: Amaranth, sans-serif; font-weight: bold; font-size: 3em; text-align: center;'>
                    Utente: ". $user_session. "
                </h1> 
                ";
            if ($result->num_rows > 0) 
            {
            
                //Creo un ciclo per l'inserimento dei dati
                echo "  
                <h1 style = 'font-family: Amaranth, sans-serif; font-weight: bold; font-size: 2.5em; text-align: center;  color: #CC2B31;'>";
                if($ruolo_session == 'Giocatore')
                    echo "Classifica Mondiale Punteggi";
                else if($ruolo_session == 'Admin')
                    echo "Elimina Punteggi";
                echo "</h1>
                <div id = 'scrollbox'>
                <table id='keywords' style = 'margin: 0 auto; font-size: 1.2em; margin-bottom: 15px;' cellspacing='0' cellpadding='0'>
                <thead>
                    <tr>";
                        if($ruolo_session == 'Admin')
                        {
                            echo "<th> Selezionato </th>"; 
                        }
                        else
                        {
                            echo "<th> Posizione </th>";                     
                        }
                        echo "<th> Nome </th>
                        <th> Punti </th>
                        <th> Data Partita </th>
                    </tr>
                </thead>
                <tbody>
                ";
                $conta = 0;
                while($row = $result->fetch_assoc()) 
                {
                    $conta = $conta + 1;
                
                    $date = new DateTime($row['DataPartita']);
                    $formatteddate = date_format($date, 'd/m/Y H:i:s');
                
                    if($row["Nome"] == $user_session)
                        echo "<tr style = 'background-color: #c2c2a3'>";
                    else
                        echo "<tr>";
                    if($ruolo_session == 'Admin')
                    {
                        echo "<form action='EliminaPunteggio.php' method='POST'>
                        <td><input type='checkbox' name='ID[]' value='".$row["ID"]."'/></td>";
                    }
                    else
                    {
                        echo "<td>".$conta."</td>";                        
                    }
                    echo "
                        <td>".$row["Nome"]."</td>
                        <td>".$row["Punti"]."</td>
                        <td>".$formatteddate."</td>
                        </tr>
                        ";
                }
                echo "</tbody> </table> </div>";
                if($ruolo_session == 'Admin')
                {
                    echo "
                    <br><br>         
                        <center><input type='submit' name='submit' value='ELIMINA PUNTEGGI SELEZIONATI' class='btn btn-danger-outline' />
                    </center></form>
                    </div>
                    <br><br>
                    <div id='wrapper'>
                    <h1 style='font-family: Amaranth, sans-serif; font-weight: bold; font-size: 2.5em; text-align: center;  color: #CC2B31;'>
                        Elimina Giocatori
                    </h1>
                    ";
                    $sql = "SELECT giocatore.Username as Username, giocatore.Nome as Nome, giocatore.Cognome as Cognome, giocatore.DataNascita as
                            DataNascita, giocatore.Paese as Paese
                            FROM giocatore
                            INNER JOIN login
                            ON giocatore.Username = login.FK_Username
                            WHERE login.Ruolo = 'Giocatore'";
                    $result = $connection->query($sql);
    
                    if ($result->num_rows > 0) 
                    {
                        echo 
                            "</h1>
                            <div id = 'scrollbox'>
                            <table id='keywords' style = 'margin: 0 auto; font-size: 1.2em; margin-bottom: 15px;' cellspacing='0' cellpadding='0'>
                            <thead>
                                <tr>
                                    <th> Selezionato </th>
                                    <th> Nome </th>
                                    <th> Cognome </th>
                                    <th> DataNascita </th>
                                    <th> Paese </th>
                                </tr>
                            </thead>
                            <tbody>
                ";
                while($row = $result->fetch_assoc()) 
                {
                
                    $date = new DateTime($row['DataNascita']);
                    $formatteddate = date_format($date, 'd/m/Y');
                
                    echo "<tr>
                        <form action='EliminaGiocatore.php' method='POST'>
                        <td><input type='checkbox' name='Username[]' value='".$row["Username"]."'/></td>
                        <td>".$row["Nome"]."</td>
                        <td>".$row["Cognome"]."</td>
                        <td>".$formatteddate."</td>
                        <td>".$row["Paese"]."</td>                        
                        </tr>
                        ";
                }
                echo 
                    "
                    </tbody> </table>
                    </div>
                    <br><br>         
                        <center><input type='submit' name='submit' value='ELIMINA GIOCATORI SELEZIONATI' class='btn btn-danger-outline' />
                    </center></form>";                    
                    }
                }  
            }
        
        //else if($ruolo_session == 'Admin')
       
        $connection->close();
    }

    //Chiudo la connessione
  ?>
 </div> 
    
<script type="text/javascript">
$(function(){
  $('#keywords').tablesorter(); 
});
</script>
</body>
</html>
