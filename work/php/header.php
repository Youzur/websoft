<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title><?= $pageTitle ?></title>
    <link rel="stylesheet" href="css/style.css">
    <?php if (isset($styleSheets) && $styleSheets != null) :
        foreach ($styleSheets as $style) :
            echo($style . "\n");
        endforeach;
    endif; ?>
    <link rel="icon" href="img/me_icon.png">
</head>
<body>
<header>
    <nav>
        <a href="me.php">Me</a> |
        <a href="report.php">Report</a> |
        <a href="about.php">About</a> |
        <a href="search.php">Search</a> |
        <a href="update.php">Update</a> |
        <a href="create.php">Insert</a>
    </nav>
</header>
</body>