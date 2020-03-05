<?php
$pageTitle = "Me";
$styleSheets = ['<link rel="stylesheet" href="css/style.css">'];
require __DIR__ . "/header.php";
?>
<body>

<!--
Comments are written as HTML style.
-->


<header>
    <nav>
        <a href="me.html">Me</a> |
        <a href="report.html">Report</a> | 
        <a href="about.html">About</a>
    </nav>
</header>



<article>

<h1>Me Page</h1>

<p><img id="myimage" src="img/dogMe.png" alt="A dog"></p>

<p>My name is Yousef Namazi.</p>

<p>I am 24 years old and I am studying at the University of Kristianstad.</p>

<p>I am currently taking the Web Development course and it is my favourite course.</p>

<p>I love hanging out with friends and meeting new people.</p>

</article>

<footer>
    <hr>
    <p>This is brought to you  by me. Please enjoy.</p>
</footer>



<script type="text/javascript" src="js/main.js"></script>
<?php
require __DIR__ . "/footer.php";
?>
</body>
</html>
