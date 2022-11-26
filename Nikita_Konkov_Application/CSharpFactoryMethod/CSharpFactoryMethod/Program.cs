using CSharpFactoryMethod;

DeveloperUnycicle devUny = new DeveloperUnycicle();
devUny.Create().TransportInfo();

DevMoto devMoto = new DevMoto();
devMoto.Create().TransportInfo();

DevCar devCar = new DevCar();
devCar.Create().TransportInfo();

DevTrack devTrack = new DevTrack();
devTrack.Create().TransportInfo();

