#! /bin/bash

echo "Attempting to Install Android SDK and NDK"
brew tap homebrew/cask
mkdir -p ~/.android/
touch ~/.android/repositories.cfg # without this file, error will occur on next step
brew cask install android-sdk
brew cask install android-ndk
yes | sdkmanager --licenses > /dev/null
sdkmanager "platform-tools" "platforms;android-28" "build-tools;28.0.3" > /dev/null
