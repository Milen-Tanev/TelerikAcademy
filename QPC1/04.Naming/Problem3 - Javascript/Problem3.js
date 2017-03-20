function ButtonClick(ev, args) {
    var myWindow = window,
        browser = window.navigator.appCodeName,
        isMozilla = (browser === "Mozilla");
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}