file:///C:/Users/Asia%20Karem/Desktop/tast%201.html?username=&email=&password=&phone=&message=&language=english&rating=50

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>HTML Form Example</title>
</head>
<body>

    <h2>HTML Form Example</h2>
    <p>This is an example of an <del>HTML4</del> <u>HTML5</u> form containing يحتوي various <mark>input</mark> controls:</p>

    <form>
        <!-- User Information Fieldset -->
        <fieldset>
            <legend>User Information</legend>
            <p>
                <label for="username">Username:</label>
                <input type="text" id="username" name="username">
            </p>
            <p>
                <label for="email">Email:</label>
                <input type="email" id="email" name="email">
            </p>
            <p>
                <label for="password">Password:</label>
                <input type="password" id="password" name="password">
            </p>
        </fieldset>

        <!-- Contact Information Fieldset -->
        <fieldset>
            <legend>Contact Information</legend>
            <p>
                <label for="phone">Phone:</label>
                <input type="tel" id="phone" name="phone">
            </p>
            <p>
                <label for="message">Message:</label><br>
                <textarea id="message" name="message" rows="4" cols="40"></textarea>
            </p>
        </fieldset>

        <!-- Subscription Fieldset -->
        <fieldset>
            <legend>Subscription</legend>
            <p>
                <label for="sub1">Subscribe to newsletter:</label>
                <input type="checkbox" id="sub1" name="subscription">
            </p>
            <p>
                <label for="sub2">Subscribe to newsletter:</label>
                <input type="checkbox" id="sub2" name="subscription">
            </p>
        </fieldset>

        <!-- Preferred Language Fieldset -->
        <fieldset>
            <legend>Preferred Language</legend>
            <p>
                <label for="language">Select your preferred language:</label>
                <select id="language" name="language">
                    <option value="english" selected>English</option>
                    <option value="spanish">Spanish</option>
                    <option value="french">French</option>
                    <option value="german">German</option>
                </select>
            </p>
        </fieldset>

        <!-- Feedback Fieldset -->
        <fieldset>
            <legend>Feedback</legend>
            <p>
                <label for="rating">Rate our service:</label>
                <input type="range" id="rating" name="rating">
            </p>
        </fieldset>

        <br>
        <!-- Submit and Reset Buttons -->
        <button type="submit">Submit</button>
        <button type="reset">Reset</button>
    </form>

</body>
</html>
