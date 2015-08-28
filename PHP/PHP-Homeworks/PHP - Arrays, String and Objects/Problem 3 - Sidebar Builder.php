<style>
    div{
        padding: 3px;
    }
</style>
<form action="" method="get">
    <div>
    <label for="categories">Categries: </label>
    <input type="text" name="categories" id="categories"/>
    </div>
    <div>
    <label for="tags">Tags: </label>
    <input type="text" name="tags" id="tags"/>
    </div>
    <div>
    <label for="months">Months: </label>
    <input type="text" name="months" id="months"/>
    </div>
    <input type="submit" name="submit"/>
</form>
<?php
$categories = explode(", ", $_GET['categories']);
$tags = explode(", ", $_GET['tags']);
$months = explode(", ", $_GET['months']);

if(isset($_GET['submit'])){
    echo "<aside style='border-radius: 5px;background-color: lightskyblue; width: 200px;'>";
    echo "<h2 >Categories</h2>";
    echo "<hr style='color:black'>";
    echo "<ul type='circle'>";
    foreach ($categories as $el1) {
        echo "<li style='text-decoration: underline'>$el1</li>";
    }
    echo "</aside>";
    echo "</ul>";

    echo "<aside style='border-radius: 5px;background-color: lightskyblue; width: 200px;'>";
    echo "<h2 >Tags</h2>";
    echo "<hr style='color:black'>";
    echo "<ul type='circle'>";
    foreach ($tags as $el2) {
        echo "<li style='text-decoration: underline'>$el2</li>";
    }
    echo "</aside>";
    echo "</ul>";

    echo "<aside style='border-radius: 5px;background-color: lightskyblue; width: 200px;'>";
    echo "<h2 >Months</h2>";
    echo "<hr style='color:black'>";
    echo "<ul type='circle'>";
    foreach ($months as $el3) {
        echo "<li style='text-decoration: underline'>$el3</li>";
    }
    echo "</aside>";
    echo "</ul>";
}

