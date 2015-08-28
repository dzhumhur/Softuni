<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
    <style>
        form{
            width: 600px;
        }
        input, .separate-line, #label-prog-lang, #langs, #driver-license{
            display: block;
        }
        #male, #female, #comp-name, #from, #to, #prog-lang, #skill-level, #remove, #add, #checkboxes, #A, #B, #C, #comprehension,
        #writing, #reading, #lang{
            display: inline-block;
        }
    </style>
</head>
<body>
    <form method="post" action="">
        <fieldset>
            <legend>Personal Information</legend>
            <input type="text" name="fname" placeholder="First Name"/>
            <input type="text" name="lname" placeholder="Last Name"/>
            <input type="email" name="email" placeholder="Email"/>
            <input type="number" name="phone-number" placeholder="Phone Number"/>
            <label for="female">Female</label>
            <input type="radio" name="gender" id="female"/>
            <label for="male">Male</label>
            <input type="radio" name="gender" id="male"/>
            <label for="birth-date" class="separate-line">Birth Date</label>
            <input type="date" name="date" id="birth-date"/>
            <label for="nationality" class="separate-line">Nationality</label>
            <select name="" id="nationality">
                <option value="Bulgarian">Bulgarian</option>
                <option value="Indian">Indian</option>
                <option value="Belgian">Belgian</option>
                <option value="German">German</option>
                <option value="Italian">Italian</option>
            </select>
        </fieldset>

        <fieldset>
            <legend>Last Work Position</legend>
            <div>
            <label for="comp-name">Company Name</label>
            <input type="text" name="cname" id="comp-name" />
            </div>
            <div>
            <label for="from">From</label>
            <input type="date" name="from" id="from"/>
            </div>
            <div>
            <label for="to">To</label>
            <input type="date" name="to" id="to"/>
            </div>
        </fieldset>

        <fieldset>
            <legend>Computer Skills</legend>
            <label for="progr-lang" id="label-prog-lang">Programming Languages</label>
            <input type="text" name="prog-lang" id="prog-lang"/>
            <select name="" id="skill-level">
                <option value="Beginner">Beginner</option>
                <option value="Programmer">Programmer</option>
                <option value="Ninja">Ninja</option>
            </select>
            <div>
                <button>Remove Language</button>
                <button>Add Language</button>
            </div>
        </fieldset>

        <fieldset>
            <legend>Other Skills</legend>
            <label for="progr-lang" id="langs">Languages</label>
            <input type="text" name="lang" id="lang"/>
            <select name="Comprehension" id="comprehension" >
                <option value="" selected disabled>-Comprehension-</option>
                <option value="beginner">beginner</option>
                <option value="advanced">advanced</option>
                <option value="intermediate">intermediate</option>
            </select>
            <select name="Reading" id="reading">
                <option value="" selected disabled>-Reading-</option>
                <option value="beginner">beginner</option>
                <option value="advanced">advanced</option>
                <option value="intermediate">intermediate</option>
            </select>
            <select name="" id="writing">
                <option value="" selected disabled>-Writing-</option>
                <option value="beginner">beginner</option>
                <option value="advanced">advanced</option>
                <option value="intermediate">intermediate</option>
            </select>
            <div>
                <button>Remove Language</button>
                <button>Add Language</button>
            </div>
            <div id="checkboxes">
                <label for="" id="driver-license">Driver's Licence</label>
            <label for="B">B</label>
            <input type="checkbox" id="B"/>
            <label for="A">A</label>
            <input type="checkbox" id="A"/>
            <label for="C">C</label>
            <input type="checkbox" id="C"/>
            </div>
        </fieldset>
        <input type="submit" value="Generate CV"/>
    </form>
</body>
</html>
<?php