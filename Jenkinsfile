pipeline{
	agent{
		node{
			label 'docker-cloud-jks'
		}
	}
	environment {
		DOTNET_IMAGE = 'mcr.microsoft.com/dotnet/sdk:8.0'
	}
	triggers{
		pollSCM '*/5 * * * *'
	}
	stages{
		stage ("Build Stage"){
			agent {
				docker {
					image 'jenkins/agent'
				}
			}
			steps{
				echo "Building..."
				sh "dotnet restore"
				sh "dotnet build --configuration Release"
			}
		}
	}
}