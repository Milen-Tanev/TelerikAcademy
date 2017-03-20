/* I managed to do some stuff (partially by myself, partially copying stuff and trying if it works),
and everything is still very confusing, so any comments will be appreciated. An error is shown in the console,
not sure why, and I am not sure if I have done everything in the task :) */

var data = (function () {
  const USERNAME_STORAGE_KEY = 'username-key';

  // start users
  function userLogin(user) {
    localStorage.setItem(USERNAME_STORAGE_KEY, user);
    return Promise.resolve(user);
  }

  function userLogout() {
    localStorage.removeItem(USERNAME_STORAGE_KEY)
    return Promise.resolve();
  }

  function userGetCurrent() {
    return Promise.resolve(localStorage.getItem(USERNAME_STORAGE_KEY));
  }
  // end users

  // start threads
  function threadsGet() {
    return new Promise((resolve, reject) => {
      $.getJSON('api/threads')
        .done(resolve)
        .fail(reject);
    })
  }

  function threadsAdd(title) {
    let body = {
      title: "title",
      creator: "JohnDoe"
    };
    return new Promise((resolve, reject) => {
      $.ajax({
        url: "api/threads",
        type: "POST",
        data: JSON.stringify(body),
        contentType: "application/json"
      })
      .done(resolve)
      .fail(reject);
    });
  }

  function threadById(id) {
    $.getJSON(`api/threads/${id}`)
      .done(reslove)
      .fail(reject);
 
  }

  function threadsAddMessage(threadId, content) {
      var body = {
            username: "JohnDoe",
            content: content
        };

             return new Promise((resolve, reject) => {
        $.ajax({
          url: `api/threads/${id}/messages`,
          type: "POST",
          data: JSON.stringify(body),
          contentType: "application/json"
        })
             .done(resolve)
             .fail(reject);
      });
  }
  // end threads

  // start gallery
  function galleryGet() {
    const REDDIT_URL = `https://www.reddit.com/r/aww.json?jsonp=?`;
    return new Promise((resolve, reject) => {
      $.getJSON(REDDIT_URL)
      .done(resolve)
      .fail(reject);
    })
  }
  // end gallery

  return {
    users: {
      login: userLogin,
      logout: userLogout,
      current: userGetCurrent
    },
    threads: {
      get: threadsGet,
      add: threadsAdd,
      getById: threadById,
      addMessage: threadsAddMessage
    },
    gallery: {
      get: galleryGet,
    }
  }
})();