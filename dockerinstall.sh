#!/bin/bash

# Requires Ubuntu 18.04 (Bionic Beaver)

echo -e "\e[92m*************** Updating system *****************************\e[0m"
sudo apt update

echo -e "\e[92m*************** Installing dependencies *********************\e[0m"
sudo apt install apt-transport-https ca-certificates curl software-properties-common

echo -e "\e[92m*************** Installing Repository ***********************\e[0m"
curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -
sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu bionic stable"
sudo apt update
apt-cache policy docker-ce

echo -e "\e[92m*************** Installing docker and docker-compose ********\e[0m"
sudo apt install docker-ce -y
sudo curl -L "https://github.com/docker/compose/releases/download/1.24.0/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose

echo -e "\e[92m*************** Enable docker autostart *********************\e[0m"
sudo systemctl enable docker

echo -e "\e[92m*************** Init ****************************************\e[0m"
service docker start
