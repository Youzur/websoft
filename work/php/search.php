<?php
/**
 * A page controller
 */
//require "data/config.php";
//require "data/function.php";

// Get incoming values
$search = $_GET["search"] ?? null;
if ($search == null) :
    $like = "%";
else:
    $like = "%$search%";
endif;
$db = connectDatabase($dsn);
$selectStatement = "SELECT * FROM tech
    WHERE id = ? OR label LIKE ? OR type LIKE ?";
$preparedStatement = $db->prepare($selectStatement);
$preparedStatement->execute([$search, $like, $like]);
$queryResult = $preparedStatement->fetchAll();
require __DIR__ . "/searchView.php"

?>
