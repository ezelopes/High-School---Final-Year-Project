<?php
include('Session.php');
?>
<!doctype html>
<html>
<head>
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
<!--
    
<div id="menu">  
<ul>
    <li><a href="Benvenuto.php">Home</a></li>
    <li class="dropdown">
        <a href="#" class="dropbtn active">Visualizza</a>
        <div class="dropdown-content">
            <a href="TuoiPunteggi.php">I tuoi Punteggi</a>
            <a href="#">Punteggi per Paese</a>
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
        <a href="#" class="navbar-brand">BasketApp</a>
    </div>
<!-- Collection of nav links, forms, and other content for toggling -->
    <div id="navbarCollapse" class="collapse navbar-collapse">
        <ul class="nav navbar-nav">
            <li><a href="Benvenuto.php">Home</a></li>
            <li class="dropdown active" >
                <a data-toggle="dropdown" class="dropdown-toggle" href="#">Visualizza<b class="caret"></b></a>
                <ul role="menu" class="dropdown-menu">
                    <li><a href="TuoiPunteggi.php">I Tuoi Punteggi</a></li>
                    <li><a href="PunteggiPaese.php">Punteggi per Paese</a></li>
                    <li><a href="PunteggiData.php">Punteggi per Data Partita</a></li>
                </ul>
            </li>
            <li><a href="#">Profilo</a></li>
        </ul>
        <ul class="nav navbar-nav navbar-right">
            <li><a href="Logout.php">Logout</a></li>
        </ul>
    </div>
</nav>
    
<br>
<form action="<?php echo $_SERVER["PHP_SELF"]?>" method="POST">
    <fieldset id="paese">
<!--
        <span style = "font-family: 'Amarante', sans-serif; font-weight: bold; font-size: 3em; text-align: center;">
            Nome Paese:
        </span>
-->
        
        <div class="form-group">
        <label class="col-xs-3 control-label" style = "font-family: 'Amarante', sans-serif; font-weight: bold; font-size: 1.5em; text-align: center; top: 20px;">
            Nome Paese:
        </label>
            <div class="col-xs-5 selectContainer" style="top: 20px;">
                <select class="form-control" name="Paese">
                    <?php
					$conn = new mysqli("localhost","root","","basketapp");
					$result = $conn->query("SELECT DISTINCT Paese FROM giocatore");
					while($row = $result->fetch_assoc()){
                    ?>
                        <option value="<?php echo (string)$row['Paese']; ?>">
							<?php echo $row['Paese']; ?>
						</option>
             
                     <?php
					}
                    $conn->close();
                    ?>
                </select>
            </div>
        </div>
        
        
<!--
        <select name="Paese" id = "soflow">
                    <?php
					$conn = new mysqli("localhost","root","","basketapp");
					$result = $conn->query("SELECT DISTINCT Paese FROM giocatore");
					while($row = $result->fetch_assoc()){
                    ?>
                        <option value="<?php echo (string)$row['Paese']; ?>">
							<?php echo $row['Paese']; ?>
						</option>
             
                     <?php
					}
                    $conn->close();
                    ?>
             
        </select>
-->
     <!--   
        <select name='paese' style='width:25%; margin-left: 3.9%;'>
        <option value = "Italia">Italia</option>
        </select><input type='text' name='paese' required='required' style='width:25%; margin-left: 3.9%;'/>    -->
        <input type='submit' name='submit' required='required' style='width:25%; margin-left: 3.9%;'/>                     
    </fieldset>
</form>
    
    
    
<br><br>
    <div id="wrapper">
        <h1 style="color: #5f74a0; font-family: Amaranth, sans-serif; font-weight: bold; font-size: 3em; text-align: center;">
            Utente: <?php echo $user_session; ?>
        </h1>   
  <?php
        
    if(isset($_POST['submit'])){
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
        
        $paese = $_POST['Paese'];
        $sql = "SELECT punteggio.FK_Username as Nome, punteggio.Punti as Punti, punteggio.DataPartita as DataPartita
        FROM punteggio, giocatore
        WHERE giocatore.Paese = '".$paese."' AND punteggio.FK_Username = giocatore.Username
        ORDER BY punteggio.Punti desc";
        $result = $connection->query($sql);
    
        if ($result->num_rows > 0) 
        {
            
            //Creo un ciclo per l'inserimento dei dati
            echo "
            <h1 style = 'font-family: Amaranth, sans-serif; font-weight: bold; font-size: 2.5em; text-align: center;  color: #CC2B31;'>
                Classifica Punteggi in '".$paese."'
            </h1>
            <div id = 'scrollbox'>
            <table id='keywords' style = 'margin: 0 auto; font-size: 1.2em; margin-bottom: 15px;' cellspacing='0' cellpadding='0'>
            <thead>
                <tr>
                    <th> Posizione </th>
                    <th> Nome </th>
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
                
                echo "
                    
                    <td>".$conta."</td>
                    <td>".$row["Nome"]."</td>
                    <td>".$row["Punti"]."</td>
                    <td>".$formatteddate."</td>
                    </tr>
                ";
            }
            echo "</tbody> </table></div>";
        }
    $connection->close();
    }
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
