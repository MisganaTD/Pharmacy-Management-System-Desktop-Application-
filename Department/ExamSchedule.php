<?php 
if (!isset($_SESSION)) 
{
  session_start();
}
if(isset($_SESSION['department']))
{
?>
<?php
}
else{
$logoutGoTo = "../index.php";
header("Location: $logoutGoTo");
}
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="EN" lang="EN" dir="ltr">
<head profile="http://gmpg.org/xfn/11">
<title>Online Examination</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<meta http-equiv="imagetoolbar" content="no" />
<link rel="stylesheet" href="styles/layout.css" type="text/css" />
<script language="javascript" type="text/javascript" src="datetimepicker.js">
</script>
<script type="text/javascript" src="validate.js" ></script>
</head>
<body id="top">
<div class="wrapper row1">
  <div id="header" class="clear">
    <div class="fl_left">
      <h1><a href="index.html">Holistic Bible College</a></h1>
      <p>ONLINE EXAMINATION SYSTEM FOR DISTANCE LEARNERS</p>
    </div>
    <div align="right" class="fl_right">
      <ul>
        
        <li class="last"> <a href="logout.php">Logout</a></li>
      </ul>
      
    </div>
	
  </div>
</div>
<!-- ####################################################################################################### -->
<div class="wrapper row2">
  <div class="rnd">
    <!-- ###### -->
    <div id="topnav">
    <?php
	$userType = $_SESSION['type'];
	if($userType == 'head')
	{
	?>
      <ul>
        <li><a href="index.php">Home</a></li>
        <li><a href="students.php">Students</a></li>
        <li><a href="course.php">course</a></li>
        <li  class="active"><a href="schedule.php">schedule</a></li>
        <li><a href="exam.php">exam</a></li>
        <li><a href="response.php">Grade</a></li>
		<li><a href="management.php">Teachers</a></li>
        
      </ul>
	  <?php
	  }
	  else if ($userType == 'teacher')
	  {
	  ?>
	   <ul>
        <li><a href="index.php">Home</a></li>
        <li  class="active"><a href="schedule.php">schedule</a></li>
        <li><a href="exam.php">exam</a></li>
        <li><a href="response.php">Grade</a></li>
        
      </ul>
	  <?php
	  }
	  ?>
    </div>
    <!-- ###### -->
  </div>
</div>

<!-- ####################################################################################################### -->
<div class="wrapper row3">
  <div class="rnd">
    <div id="container" class="clear">
      <!-- ####################################################################################################### -->
	  <form name="form1" method="post" action="" id="validateCourse" onsubmit="return validateExamSchedule('validateCourse');">
      <table width="200" border="0">
	  <tr>
	  <td width="15%" height="92">
			  
			  <p><a href="schedule.php">Add New Event</a></p>
		      <p><a href="post_schedule.php">Event Schedule</a></p>
		      <p><a href="ExamSchedule.php">Exam Schedule</a></p>
		      <p><a href="manage_schedule.php">Manage Schedule</a></p></td>
			<td><div align="justify"><u> </u>
		      </div></td>
	  </tr>
            <tr>
              <td width="15%" height="210"> </td>
              <td width="85%"><table width="77%" border="0">
                <tr>
                  <td width="13%" height="53">Exam Course: </td>
                  <td width="87%">
				  
				  <?php
				$con = mysqli_connect ("localhost","root","","online");
            //mysqli_select_db("online", $con);
			?>
			<?php $event= mysqli_query($con,"select * from course where department = '".$_SESSION['department']."'"); ?>

             <select name="course">
             <?php while($result= mysqli_fetch_assoc($event))
                         { ?>
                    <option>
                    <?php echo $result['course_title']?>
                    </option>
                    <?php }?>
                    </select></td>
					<?php// $_SESSION['course_code'] = $result['course_code']?>
					<?php mysqli_close($con)?>
                </tr>
				 <tr>
                  <td height="33">Exam Term:</td>
                  <td><select name="term">
                    <option selected="selected">QUIZ</option>
                    <option>MID</option>
                    <option>FINAL</option>
                  </select></td>
                </tr>
                <tr>
                  <td height="33">Year:</td>
                  <td><select name="year">
                    <option selected="selected">1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
                    <option>5</option>
                  </select></td>
                </tr>
                <tr>
                  <td height="33">Semister:</td>
                  <td><select name="semister">
                    <option selected="selected">1</option>
                    <option>2</option>
                 </select></td>
				 
				<tr>
                  <td height="33">Exam Time:</td>
                  <td><input name="time" type="text" size="34" /></td>
                </tr>
				 
                </tr>
                <tr>
                  <td height="40">Exam Date:</td>
                  <td> <input name="strtDate" type="text" id="strtDate" size="28" readonly>
                  <a href="javascript:NewCal('strtDate','ddmmyyyy',false,24)"><img src="cal.gif" width="16" height="16" border="0" alt="Pick a date"></a></td>
                </tr>
                <tr>
                  <td height="33">&nbsp;</td>
                  <td><input type="submit" name="Submit" value="Add" /></td>
				  
                </tr>
              </table>                
              <p>	    
			  
			 
			  
			          <!-- ================================================================================================== -->
			    
			  
			    
	            <!-- ================================================================================================== -->
		        </p>
              </td>
            </tr>
          </table>
	  </form>	
	  
	   <?php
			  if(isset($_POST['Submit']))
			  {
	$course=$_POST['course'];
	$start=$_POST['strtDate'];
	$year=$_POST['year'];
	$semister=$_POST['semister'];
	$term=$_POST['term'];
	$time=$_POST['time'];
			
	$con = mysqli_connect ("localhost","root","","online");
	
	//mysqli_select_db("online", $con);
	//-------------------------------------------------------------------------------
			$sql1 = "SELECT * FROM examschedule where examDate = '".$start."'";
$result = mysqli_query($con,$sql1);
while($row = mysqli_fetch_array($result))
{
$ExistedEvent = $row['examDate'];
} 
$events = mysqli_num_rows($result);
if($events > 0)
{
echo '<script type="text/javascript">alert("There is Already Other Exam Today!");</script>';
}
else if($events == 0)
  {
	
	//-------------------------------------------------------------------------------
	$sql = "insert into examschedule(examCourse,examTerm,examTime,examDate,department,year,semister) values('".$course."','".$term."','".$time."','".$start."','".$_SESSION['department']."','".$year."','".$semister."')";
	mysqli_query ($con,$sql);
	mysqli_close ($con);
	echo '<script type="text/javascript">alert("Schedule Added!");window.location=\'ExamSchedule.php\';</script>';
			  }
	}		  
			  ?>

      <!-- ####################################################################################################### -->
    </div>
  </div>
</div>
<!-- ####################################################################################################### -->
 
<!-- ####################################################################################################### -->
<div class="wrapper">
  <div id="copyright" class="clear">
    <p class="fl_left">&copy;  All Rights Reserved - <a href="#">Domain Name</a></p>
    
  </div>
</div>
</body>
</html>
