#  COMP3931-Pixel Art Generation
## Project Description
This is an interactive program that allows the user to upload a photo and then customize it based on their preferences, such as the pixelization factor, different pixelization methods, the number of colours, and so on. Then it generates higher-quality pixel art while fully preserving pixel art's unique artistic characteristics. 
## Features
### **Pixelation**  
* User can change the pixelation degree by changing the parameters of the settings.  
* Users can change the blur level to control the amount of detail they want to output.  
### **Colors**  
* User can choose the color of the pixels to use different calculation methods by choosing different pixelation methods.  
* Users can adjust the results by changing the scale of different parameters.  
The user can control the number of colors.  
### **Other**  
* User drags the picture to be tested into the PictureBox.  
* User can save the generated results.  
  
## Deploy
If you don't have visual studio, you can first download it through this link: https://visualstudio.microsoft.com/zh-hans/  
Then choose to develop and install through the windows platform.  
After downloading the program, you can open the project through the `pixelator.sln` file
## Usage
After the program runs, you can open the picture you want to test through the `File` in the menu bar or directly drag the image into the `picture-box` above.  
Then click `Pixelation button` and `Colors button` in the left function bar to expand the corresponding functional area.  
### **Pixelation:**  
The pixelate factor and blur can be controlled using the `track-bar` or `text-box` to change the degree of pixelation and the amount of detail preserved. 
  
### **Colors:**  
You can choose whether to use another pixelation method through the `check-box`, and then you can choose a different pixelation method through the `combo-box`:  
* Get the maximum value of pixels from the original image.  
* Get the maximum value of pixels from the blurred image.  
* Get the three largest values from the original image and get the average.  
* Get the maximum value from the original image and the blurred image, then calculate the final value based on the maximum value of the original image*(1-x)+the maximum value of the blurred image* (0≤x≤1).  
(You can control the size of x through track-bar)  

The number of colors output can be controlled by `combo-box`.  
### Generate and Save Results:
Click the `Pixelate button` to generate the result.  
After getting satisfactory results, you can save it through the `File` in the menu bar.  
