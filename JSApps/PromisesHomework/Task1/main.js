(function func() {
    // It didn't work with Chrome for me, try with Mozilla. Sometimes needs a few seconds to load
    
    let container = document.querySelector("#container");
    let currentCoords = { };    

    navigator.geolocation.getCurrentPosition((position) => {
        currentCoords = {
            lat: position.coords.latitude,
            lon: position.coords.longitude
        }
        
    let src = "http://maps.googleapis.com/maps/api/staticmap?center=" + currentCoords.lat + "," +
    currentCoords.lon + "&zoom=13&size=500x500&sensor=false";
    let img = document.createElement("img");
    img.src = src;
    container.appendChild(img);    
    console.log(currentCoords.lat);
    console.log(currentCoords.lon);
    });
}());
