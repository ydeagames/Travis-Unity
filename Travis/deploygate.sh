#! /bin/sh

if [ "${TRAVIS_BRANCH}" = "stable" -a "${TRAVIS_PULL_REQUEST}" = "false" ]; then
  curl -F "file=@./Build/android.apk" -F "token=${DEPLOYGATE_API_TOKEN}" https://deploygate.com/api/users/name/apps
fi