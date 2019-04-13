echo 'Generating Secrets...'
tar cvf secrets.tar travis.p12 travis.mobileprovision
cd ../../
echo y | travis encrypt-file ./Travis/Secrets/secrets.tar ./Travis/Secrets/secrets.tar.enc
echo 'Generating Secrets Completed'
@pause