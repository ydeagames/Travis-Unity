#! /bin/sh

brew install caskroom/cask/android-sdk caskroom/cask/android-ndk
export ANDROID_SDK_ROOT=/usr/local/share/android-sdk
export ANDROID_NDK_ROOT=/usr/local/share/android-ndk
# sdkmanager --package_file=[sdkmanagerのドキュメントを参照して依存を書いたファイルを指定して下さい]