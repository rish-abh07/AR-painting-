# AR-painting
AR Painting is a project that was used in the NIT Hamirpur Technical Fest "Nimbus" and allows users to scan pictures and view 3D models on their screen.
The project has been integrated with the NIMBUS app, which was made using the Dart programming language on Flutter framework .

# Challenges
Integration of Unity with Flutter was one of the biggest challenges we faced while developing the AR Painting project. We conducted extensive research online and came across an article by Mohammed Bably [https://blog.codemagic.io/how-to-embed-an-android-unity-game-in-a-flutter-app/], which provided helpful guidance for integrating the two technologies. We even did a demo run with a simple cube app and Flutter app to test the integration.

However, as with any project, we encountered several issues during the integration process. We knew that encountering problems is a natural part of development and that we needed to approach them with a problem-solving mindset. Through persistence and experimentation, we were able to successfully integrate Unity with Flutter and create a seamless user experience.

We hope that our experience and approach can help other developers who are working on similar projects and facing similar challenges.

## Integration 

One improvement I recommend is to always import the latest package, as using an older version can lead to unexpected errors. During our experiment, we encountered issues that took us three days to solve, but we were able to overcome them by using the latest package available.

Unfortunately, we don't have any screenshots to share, but if you encounter any issues, I recommend checking out the unitypackages repository for further guidance.

In summary, when integrating Unity with Flutter, it's important to use the latest package (https://github.com/juicycleff/flutter-unity-view-widget/tree/master/unitypackages) available and be prepared to tackle any unique errors that may arise during the integration process.
One of the error I remember was due to Newtonsoft.Json.dll file something related to its repeation .To avoid issues with duplicate Newtonsoft.Json.dll files, you can try removing or unchecking the Jasndotnet folder when importing the project.
![Article 1](https://user-images.githubusercontent.com/96663526/235212132-1f34f6f8-14b7-4893-819e-af689c876e4d.png)
