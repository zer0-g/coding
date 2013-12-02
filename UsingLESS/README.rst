LESS.js

Step 1. Reference LESS.js
=========================
::

 <script src="http://lesscss.googlecode.com/files/less-1.0.18.min.js"></script>

Step 2. Import a Stylesheet
===========================

::

 <link rel="stylesheet/less" href="style.less" />  
 Note that we�ve set the rel attribute to �stylesheet/less,� and that our actual stylesheets has an  extension of .less, not .css. Also, we must link to this stylesheet before Less.js.


Step 3. Have Fun!
=================

::

 With this minimal amount of work, you now have access to everything from variables to mix-ins. Be   sure to watch the four minute video tutorial above for full examples, but here are a few quickies.
 view plaincopy to clipboardprint?

 /* 
 Variables! 
 */  
 @primary_color: green;  
  
 /*  
 Mix-ins are like functions for commonly used operations, 
 such as apply borders. We create variables by prepending 
 the @ symbol.  
 */  
 .rounded(@radius: 5px) {  
    -moz-border-radius: @radius;  
    -webkit-border-radius: @radius;  
    border-radius: @radius;       
 }  
  
 #container {  
 /* References the variable we created above. */  
    background: @primary_color;  
          
 /* Calls the .rounded mix-in (function) that we created, and overrides the default value. */  
    .rounded(20px);   
      
 /* Nested selectors inherit their parent's selector as well. This allows for shorter code. */  
    a {  
        color: red;  
    }  
 }
