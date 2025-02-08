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
		stage ("Delivery and Deploy"){
			agent {
				docker {
					image 'mcr.microsoft.com/dotnet/sdk:8.0'
					args '--user root'
				}
			}
			steps{
				echo "Delivering..."
				sh "mkdir -p /home/publish && cp -r DotNetJks /home/publish"
			}
		}
	}
}