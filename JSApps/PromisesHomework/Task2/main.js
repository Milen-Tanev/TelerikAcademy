(function func() {
    let message = document.querySelector("#message");

    let promise = new Promise((resolve, reject) => {
        setTimeout(() => {
            message.style.display = "none";
            window.location = "http://pavelkolev.com/wp-content/uploads/2014/04/javascript_1.jpg";
        }, 2000);
    });
    
    // Included some useless stuff, so that something happens while waiting
    var n = 100;
    var tm = setInterval(countDown, 20);
    function countDown(){
    n -= 1;

    if(n == 0){
        clearInterval(tm);
    }
    message.innerText = "Awesome message disappears in " + n;
        
    };
    // End of useless stuff
}());