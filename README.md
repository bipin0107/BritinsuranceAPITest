# Create a README file and initialize the Git repository
echo "# BritinsuranceAPITest" > README.md
git init

# Stage the README file and commit
git add README.md
git commit -m "Initial commit"

# Set the main branch and add the remote repository
git branch -M main
git remote add origin https://github.com/bipin0107/BritinsuranceAPITest.git

# Push the changes to the remote repository
git push -u origin main
