#!/bin/bash

npm install -g node-inspector
ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/uninstall)"
ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"
brew install rbenv ruby-build
echo 'if which rbenv > /dev/null; then eval "$(rbenv init -)"; fi' >> ~/.bash_profile
source ~/.bash_profile
rbenv install 2.3.1
rbenv global 2.3.1
ruby -v
brew install --HEAD ideviceinstaller
sudo gem install cocoapods
pod setup
cd Appium-Dot-App
pod install
cd ../