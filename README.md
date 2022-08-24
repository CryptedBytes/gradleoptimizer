# Gradle Optimizer / Batch Gradle Cleaner
Run Gradle clean on all projects in a directory - with a single click!

Net Framework 4.7.2 is required

# How does it work?
GradleOptimizer iterates through all files in your Android Studio projects folder and runs 'gradlew --clean' command on them.

# Why would I need this?
Your projects may grow in size significantly after some time. This is a bigger issue especially if you are working on several projects. The projects not only grow large in size but also in number. Usually, Android Studio projects contain hundreds if not thousands of small files, making it harder to copy/duplicate project folders around on Windows because the default file system, NTFS, does not support copy-on-write. With GradleOptimizer, you can run Gradle clean on all your Android Studio projects with a single click and it will reduce the excessive file count as well as reduce the size that the project folder takes. See below to get an idea of much you can save. TLDR: Check average savings section below

# Average savings:
On a folder with 8 projects, GradleOptimizer can

- Reduce total project size **up to 83.44%**

- Reduce the number of files **up to 88.12%**

Before and after the optimization run:

![Comparison](https://raw.githubusercontent.com/CryptedBytes/gradleoptimizer/main/repoimages/screen_comparison.png)



# Screenshots of the UI
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/gradleoptimizer/main/repoimages/screen_ui0.png)
![Screenshot of the UI](https://raw.githubusercontent.com/CryptedBytes/gradleoptimizer/main/repoimages/screen_ui1.png)

# Features / To-do
- [x] Batch Gradle optimization on all projects in a directory
- [x] Minimal and easy-to-use UI
- [x] Full drag-and-drop support
- [x] Checks if the project directory is valid
- [x] Reports optimization progress
- [x] Ability to hide or show Gradle console windows
- [x] Sends ZERO telemetry/data and never connects to the internet
- [x] Just ~14 kilobytes in size
- [ ] Further UI polishing
- [ ] Report progress in a more intuitive way with a percentage progress bar
- [ ] Support working with more than one project folder at a time
