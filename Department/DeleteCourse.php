<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<title>Untitled Document</title>
</head>
<body>
<?php

	$Id=$_GET['CourseId'];
	$con = mysqli_connect ("localhost","root","","online");
	//mysqli_select_db("online", $con);
	$sql = "delete from course where course_code='".$Id."'";
	mysqli_query ($con,$sql);
	mysqli_close ($con);
	echo '<script type="text/javascript">alert("Course Deleted Succesfully");window.location=\'manage_course.php\';</script>';

?>
</body>
</html>
