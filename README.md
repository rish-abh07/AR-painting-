# AR-painting
AR Painting is a project that was used in the NIT Hamirpur Technical Fest "Nimbus" and allows users to scan pictures and view 3D models on their screen.
The project has been integrated with the NIMBUS app, which was made using the Dart programming language on Flutter framework .

# App Demo  


<!-- open in app -->


https://github.com/rish-abh07/AR-painting-/assets/96663526/4c091100-1c18-49c7-b512-eb841254695e

<!-- app preview  -->
https://github.com/rish-abh07/AR-painting-/assets/96663526/5e30eb17-e09f-455a-b267-afc5ec99fd76

<!-- demo images  -->
 ![WhatsApp Image 2023-05-12 at 12 48 52 AM](https://github.com/rish-abh07/AR-painting-/assets/96663526/3606cf83-d7eb-4e28-a5c7-b3634132680d)
 ![WhatsApp Image 2023-05-12 at 12 44 50 AM](https://github.com/rish-abh07/AR-painting-/assets/96663526/c013ae52-e074-4cd3-9d3c-673693fa5c7f)


# You can find the app here :

Though its only restricted for Nit hamirpur students
[https://play.google.com/store/apps/details?id=com.appteamnith.nimbus2k23]


# Challenges
Integration of Unity with Flutter was one of the biggest challenges we faced while developing the AR Painting project. We conducted extensive research online and came across an article by Mohammed Bably [https://blog.codemagic.io/how-to-embed-an-android-unity-game-in-a-flutter-app/], which provided helpful guidance for integrating the two technologies. We even did a demo run with a simple cube app and Flutter app to test the integration.

However, as with any project, we encountered several issues during the integration process. We knew that encountering problems is a natural part of development and that we needed to approach them with a problem-solving mindset. Through persistence and experimentation, we were able to successfully integrate Unity with Flutter and create a seamless user experience.

We hope that our experience and approach can help other developers who are working on similar projects and facing similar challenges.

## Integration - flutter-unity-widget 
 
 ### Unity 
One improvement I recommend is to always import the latest package, as using an older version can lead to unexpected errors. During our experiment, we encountered issues that took us three days to solve, but we were able to overcome them by using the latest package available.

Unfortunately, we don't have any screenshots to share, but if you encounter any issues, I recommend checking out the unitypackages repository for further guidance.

In summary, when integrating Unity with Flutter, it's important to use the latest package (https://github.com/juicycleff/flutter-unity-view-widget/tree/master/unitypackages) available and be prepared to tackle any unique errors that may arise during the integration process.
One of the error I remember was due to Newtonsoft.Json.dll file something related to its repeation .To avoid issues with duplicate Newtonsoft.Json.dll files, you can try removing or unchecking the JsonDotNet folder when importing the project.
![Article 1](https://user-images.githubusercontent.com/96663526/235212132-1f34f6f8-14b7-4893-819e-af689c876e4d.png)

Next, it was not much problem with Unity":

I had a positive experience with Unity, as the tutorial worked just fine and all steps were easy to follow. The Unity part of the project was good to go, and I did not encounter any major issues.

### Flutter
And then comes Flutter. Although I did not have any experience with Flutter, I took help from a senior member of the app team. However, integrating Unity with Flutter turned out to be one of the most challenging experiences I have ever had. We started with the tutorial provided in the article, but we encountered multiple errors along the way. It felt like we were stuck in a maze with no way out. Fortunately, the senior member was very knowledgeable and helped me navigate through the issues. One important thing to note is that you need to use Flutter and Unity on the same device, which was not mentioned in the article.Why so ?

During the process of building the app in Flutter, we encountered a major error that many Android developers might overlook: 'NDK not Found'. It refers to the native development kit that is required for certain functions in the app. This error caused a lot of confusion for us, but with the help of the senior member, we were able to resolve it. It is important to note that when using Flutter, you need to have the NDK installed and set up correctly.


This error was something which ain't find easily but somehow we solved .First download the ndk from android studio and then after downloading the NDK from the Android Studio and finding its location in the path C:\Users\youruserfolder\AppData\Local\Android\Sdk\ndk\21.3.6528147, you need to copy the NDK and paste it in the Unity folder. The path of the Unity folder can be found in the Unity Editor by going to Edit -> Preferences -> External Tools -> Android -> NDK. Then, you can set the path to the NDK you copied earlier. This will solve the NDK not found error while building the Flutter app with Unity integration.
![image](https://user-images.githubusercontent.com/96663526/235223308-3c18a80a-68f5-4ef4-a9bf-5b8c202e1768.png)

and then again export project (note : first save the project in a folder name unity inside the flutter project and then export build or release )
Also remember to set the path of ndk in local.properties as shown in this article https://pub.dev/packages/flutter_unity_widget

### Optimization 

Optimizing the size was a major challenge for us. We had to use different techniques such as reducing the polygon count, optimizing texture sizes, and compressing the models to reduce their size without compromising quality. We also had to keep in mind the app's performance while doing this, as we didn't want it to lag or crash while rendering the 3D models. To address this, we used a plugin in Blender called the MetaSpark Plugin.


Another challenge we faced was with AR tracking and placement of the 3D models. We had to ensure that the models were placed accurately on the scanned image and that they stayed in place as the user moved their device. This required extensive testing and tweaking of the AR tracking algorithms.


Initially, we attempted to create all the models in one file and then import it into Unity. However, we quickly realized this was not an optimal approach. Instead, we separated the files one by one and then adjusted them in Unity using the Vuforia SDK for AR. In Unity, we compressed the textures and models, and then used an external tool to further compress the textures. As a result, we were able to reduce the size from over 1.89 GB to just 89 MB. 
This taught us the importance of patience and perseverance in a project like this.



Overall, the project was a great learning experience for us, and we were able to overcome these challenges with the help of online resources and the guidance of our senior team members.
