<!DOCTYPE html>
<html lang="en">

</html>
<html>

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="./styles/normalize.css">
    <link rel="stylesheet" href="./styles/small.css">
    <link rel="stylesheet" href="./styles/small-medium.css">
    <link rel="stylesheet" href="./styles/medium.css">
    <link rel="stylesheet" href="./styles/large.css">
    <link href="https://fonts.googleapis.com/css?family=IM+Fell+Great+Primer+SC&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Raleway&display=swap" rel="stylesheet">

    <title> Information </title>
    <!-- Home Page for B&M Storage-->

</head>

<body>
    <div class="parallax-home">

        <div class="header" id="myHeader">
            <section class="headings">
                <!-- <h1 class="logo-box-1">B&M  STORAGE</h1> -->
                <!-- motto or slogan: This needs work -->
                <!-- <div class='moto'>Simple Storage. Affordable pricing.</div> -->
                <img class="Site-Logo" src="./images/Artboard 1.png" alt="Logo of a Lock">
                <div class="navigation-grid-hamburger">
                    <nav>
                        <ul class="navigation">
                            <li><a href="#" onclick="toggleMenu()">&#9776; Menu</a></li>
                            <li><a href="./index.html">Home</a></li>
                            <li><a class="active" href="./info.html"> Info / Units</a></li>
                            <li><a href="./register.html">Register</a></li>
                            <li><a href="./account.html">Create Account</a></li>
                            <li><a href="./contact.html">Contact</a></li>
                        </ul>
                    </nav>
                </div>
            </section>
        </div>
        
        <div class="content">
            <!--  A call to action to make a sign up for a unit  -->
            <div class="image-test"></div>

            <section class = "call-to-action">
                <!-- Call To Action-->
                <section class="cta-img">
                    <p class="intro-p">
                        You won't beat our prices!
                    </p>
                    <p class="intro-p">
                        Get in a Unit Today!
                    </p>
                    <button type="submit" class="btn">Contact Us!</button>
                </section>
            </section>

               
                  
                        <main id="stormCenterMain">
                                <div class="parallax-storm-center">
                        
                                <h2>
                                   Please Enter Your Information
                                </h2>
                  
                                <!-- Generall this would be POST but we use get because GITHUB support only GET -->
                                <form action="./thanks.html" method="GET">
                        
                                    <h2> Reserve your Room:</h2>
                                    <!-- A. full name using input of type text and is required and only accepts alpha characters with a minimum of five characters using a regular expression pattern -->
                                    <div>
                                        <label for="fullName">Full Name: </label>
                                        <input type="text" id="fullName" name="fullName" pattern=".{5,}" required>
                                    </div>
                        
                        
                                    <!-- B. email using input of type email and use a placeholder to provide a demo email -->
                                    <div>
                                        <label for="email">Email: </label>
                                        <input type="email" id="email" name="email" placeholder="example1@gmail.com">
                                    </div>
                        
                        
                                    <!-- C. phone number using input of type tel and is required -->
                                    <div>
                                        <label for="phone">Phone Number: </label>
                                        <input type="tel" id="phone" name="phone" required>
                                    </div>

                                    <div>
                                        <label for="fullName">Address: </label>
                                        <input type="text" id="address" name="address" required>
                                    </div>
                        
                        
                                    <!-- D. zip code using input of type number and is required -->
                                    <div>
                                        <label for="zipCode">Zip Code: </label>
                                        <input type="number" id="zipCode" name="zipCode" required>
                                    </div>

                                        <!-- H. storm region using select with drop-down options of "Preston", "Sugar City", and "Fish Haven". 
                                            Add a first option with the text "Select Region ..." that is shown by default but not selectable (disabled).
                                            The rest of the options should have relevant value attributes. -->
                                            <div>
                                                <label for="Region">Hotel Destination: </label>
                                                <select name="cityList" id="Region">
                                                    <option value="" selected disabled>Select Hotel</option>
                                                    <option value="Salt Lake">Salt Lake</option>
                                                    <option value="Fort Collins">Fort Collins</option>
                                                    <option value="Rome">Rome</option>
                                                    <option value="San Diego">San Diego</option>
                                                </select>
                                            </div>
                                

                                      <!-- E. storm date using input of type date -->
                                      <div>
                                        <label for="stormType"> Number of Rooms: </label>
                                        <input list="stormTypes" id="roomType" name="stormType" placeholder="1...">
                                        <datalist id="stormTypes">
                                            <option value="1"></option>
                                            <option value="2"></option>
                                            <option value="3"></option>
                                            <option value="4"></option>
                                        </datalist>
                                    </div>
                        
                        
                                    <!-- E. storm date using input of type date -->
                                    <div>
                                        <label for="stormDate">Arrival Day: </label>
                                        <input type="date" id="arrival" name="stormDate">
                                    </div>

                                    <div>
                                        <label for="stormDate">Departure Day: </label>
                                        <input type="date" id="departure" name="stormDate">
                                    </div>
                        
                        
                        
                                    <!-- F. storm type using input with a list attribute referencing a datalist of suggestions that include "Flash Flood," "Hail," "Hurricane," "Thunderstorm," and "Tornado." -->
                                    <div>
                                        <label for="stormRegion">Room Type: </label>
                                        <select name="cityList" id="stormRegion">
                                            <option value="" selected disabled>Select Room</option>
                                            <option value="1 Adult - 1 Full Size Bed">1 Adult - 1 Full Size Bed</option>
                                            <option value="2 Adults - 1 Full Size Bed">2 Adults - 1 Full Size Bed</option>
                                            <option value="2 Adults - 1 Queen Size Bed">2 Adults - 1 Queen Size Bed</option>
                                            <option value="2 Adults - 1 King Size Bed">2 Adults - 1 King Size Bed</option>
                                            <option value="2 Full Size Beds">2 Full Size Beds</option>
                                            <option value="2 Queen Size Beds">2 Queen Size Beds</option>
                                            <option value="2 King Size Beds">2 King Size Beds</option>
                                        </select>
                                    </div>
                                                         
                        
                        <h2>Please Enter Your Payment Information</h2>


                          <!-- A. full name using input of type text and is required and only accepts alpha characters with a minimum of five characters using a regular expression pattern -->
                          <div>
                            <label for="fullName">Card Holders Name: </label>
                            <input type="text" id="fullName" name="fullName" pattern=".{5,}" required>
                        </div>
            
            
                              
                        <!-- D. zip code using input of type number and is required -->
                       

                        <div>
                            <label for="zipCode">Card Number: </label>
                            <input type="number" id="zipCode" name="zipCode" pattern=".{16,}"  placeholder="8520025885200258" required>
                        </div>

                        <div>
                            <label for="zipCode">Security Code: </label>
                            <input type="number" id="zipCode" name="zipCode" pattern=".{3,}" placeholder="021" required>
                        </div>
                        

                          <!-- E. storm date using input of type date -->
                          <div>
                            <label for="stormType"> Expiration Date: </label>
                            <input list="stormTypes" id="stormType" name="stormType" placeholder="01/21">
                            <datalist id="stormTypes">
                                <option value="1"></option>
                                <option value="2"></option>
                                <option value="3"></option>
                                <option value="4"></option>
                            </datalist>
                        </div>

                        <div>
                            <label for="comments" class="align-top">Comments: </label>
                            <textarea name="comment" id="commentBox" cols="28" rows="10" placeholder="If you requre any Special Accomidations please enter them here..."></textarea>
                        </div>
            
                                    <!-- K. form submission button using input of type submit -->
                                    <div id="submitReset">
                                        <input type="submit" value="Submit">
                                        <input type="reset" value="Reset">
                                    </div>

                        
                                </form>
                        

               <!-- contact information for the hotel chain -->
               <!-- <section class="contact">
                    <h2>Contact Infomration</h2>
                    <div class="article-box">
                        <iframe
                            src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3053.6980275686024!2d-111.67383426000858!3d40.05983937940822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x874da4b42a2bae79%3A0x6b6c439374501d1a!2sB%26M%20Storage!5e0!3m2!1sen!2sus!4v1571072032478!5m2!1sen!2sus"
                            width="400" height="300" frameborder="0" style="border:0;" allowfullscreen=""></iframe>
    
                        <div class="contact-p">
                            <p> Temples Inn & Suites:</p>
                            <p> 16645 Nowheresville USA</p>
                            <p> NoOneCares Utah</p>
    
                            <span style='font-size:20px; margin: 2em;'>&#9742; 999-999-9999</span>
                        </div>
                    </div>
                </section>
            
            </div>
            </section> -->
        <!-- <iframe
        src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3053.6980275686024!2d-111.67383426000858!3d40.05983937940822!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x874da4b42a2bae79%3A0x6b6c439374501d1a!2sB%26M%20Storage!5e0!3m2!1sen!2sus!4v1571072032478!5m2!1sen!2sus"
        width="400" height="300" frameborder="0" style="border:0;" allowfullscreen=""></iframe> -->

    </main>

    <footer>
        <div class="footer">
            <p class='footer-text'> CIT230 &copy; <span id="currentDate"> &star; Ryan P. Harris | Colorado | BYUI
                </span></p>
        </div>
    </footer>

    <!-- <script src="./scripts/retrievejsondata.js"></script> -->
    <!-- <script src="./scripts/retrieveCityjsondata.js"></script> -->
    <script src="./scripts/main.js"> </script>
    <!-- <script src="scripts/windchill.js"></script>
    <script src="scripts/weatherSummary.js"></script>
    <script src="scripts/fivedayforecast.js"></script> -->
    <script src="./scripts/adjustRating.js"></script>


</body>

</html>



   


