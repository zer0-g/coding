<?php
$name = isset($_POST['name']) ? $_POST['name'] : 'World';
?>
<html>
	<body>
        <h1>Hello <?php echo $name; ?>!</h1>
        <form method="post">
            Your Name: <input type="text" name="name" value="<?php echo $name; ?>">
            <input type="submit">
        </form>
	</body>
</html>