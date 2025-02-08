pipeline{
	agent{
		node{
			label 'docker-dotnet2'
		}
	}
	triggers{
		pollSCM '*/5 * * * *'
	}
	stages{
		stage ("Build"){
			agent {
				docker {
					image 'mcr.microsoft.com/dotnet/sdk:8.0'
					args '--user root'
				}
			}
			steps{
				echo "Building..."
				sh 'pwd && ls -l'
				sh 'cd DotNetJks && dotnet build'
			}
		}
	}
}