# Maui9078_Scrollview_Resizing_IOS_Repro

This maui project aims to reproduce an error where dynamically resizing elements within a scroll view (at least on ios) does not update the scrolling region of the scrollview, therefore cutting off the children elements within unless you force a layout/rendering update by either rotating the screen or navigating to a different page then back.

The dynamically resized elements in this project are in the form of a custom webview, which resizes based on it's contents height. 

Here is a [screen recording](https://ascensiongamedev.com/resources/filehost/b9e28a3f47ea1387e93c1e86526df7ad.mov) of the issue.

In the above recording you will see the app initially load the MainPage (slowly on an old iPhone 6).

After the videos load and properly resize I am unable to scroll to the bottom of the page.

After rotating the screen I can freely scroll down and see all of the web view elements.
 
