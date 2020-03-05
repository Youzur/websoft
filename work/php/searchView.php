<?php
$pageTitle = "Search";
require __DIR__ . "/header.php";
?>

<table>
    <?php if (empty($queryResult)):
        echo("<th>No results from search: '$search'</th>");
    else: ?>
        <tr>
            <th>Id</th>
            <th>Label</th>
            <th>Type</th>
        </tr>
        <?php foreach ($queryResult as $row) : ?>
            <tr>
                <td><?= $row["id"] ?></td>
                <td><?= $row["label"] ?></td>
                <td><?= $row["type"] ?></td>
            </tr>
        <?php endforeach;
    endif;
    ?>
</table>

<?php require __DIR__ . "/footer.php"; ?>
</body>
</html>