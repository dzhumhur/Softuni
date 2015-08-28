<?php
session_start();
?>
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <style>
        p{
            font-size: larger;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <p>Enter HTML Tags</p>

    <form method="post" action="">
        <input type="text" name="input" id="input"/>
        <input type="submit" name="submit"/>
        <p>
            <?php
            $validTags = ["!DOCTYPE", "a", "abbr", "acronym", "address", "applet", "area", "article", "aside", "audio", "b", "base", "basefont", "bdi",
                "bdo", "big", "blockquote", "body", "br", "button", "canvas", "caption", "center", "cite", "code", "col", "colgroup", "datalist", "dd",
                "del", "details", "dfn", "dialog", "dir", "div", "dl", "dt", "em", "embed", "fieldset", "figcaption", "figure", "font", "footer", "form",
                "frame", "frameset", "h1", "h2", "h3", "h4", "h5", "h6", "head", "header", "hgroup", "hr", "html", "i", "iframe", "img", "input", "ins",
                "kbd", "keygen", "label", "legend", "li", "link", "main", "map", "mark", "menu", "menuitem", "meta", "meter", "nav", "noframes", "noscript",
                "object", "ol", "optgroup", "option", "output", "p", "param", "pre", "progress", "q", "rp", "rt", "ruby", "s", "samp", "script", "section",
                "select", "small", "source", "span", "strike", "strong", "style", "sub", "summary", "sup", "table", "tbody", "td", "textarea", "tfoot", "th",
                "thead", "time", "title", "tr", "track", "tt", "u", "ul", "var", "video", "wbr"];
            $isValid = true;
            $checkInput = $_POST['input'];

                if(isset($_POST['submit'])){
                   if (in_array($checkInput, $validTags)) {
                       $_SESSION['counter'] += 1;
                       $_SESSION['checkFirstInputIsValid']++;
                       echo 'Valid HTML tag!' . "<br/>" . 'Score: ' . $_SESSION['counter'];
                   } else {
                       if($_SESSION['checkFirstInputIsValid'] == 0){
                           echo '<style> #input {background-color: #FAFFBD}</style>';
                           echo 'Invalid HTML tag!' . "<br/>" . 'Score: ' . 0;
                       }else {
                           echo '<style> #input {background-color: #FAFFBD}</style>';
                           echo 'Invalid HTML tag!' . "<br/>" . 'Score: ' . $_SESSION['counter'];
                       }
                   }
                }
            ?>
        </p>
    </form>
</body>
</html>
