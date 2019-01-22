function start() {

    firebase.initializeApp({
        apiKey: "AIzaSyC1xYSLJzVCHPZQjPoZvfuSp-bpkIyFESc",
        authDomain: "pruebafirebase-ab801.firebaseapp.com",
        databaseURL: "https://pruebafirebase-ab801.firebaseio.com",
        projectId: "pruebafirebase-ab801",
        storageBucket: "pruebafirebase-ab801.appspot.com",
        messagingSenderId: "421403369776"
    });

    // Initialize Cloud Firestore through Firebase
    db = firebase.firestore();
    getRemittances();

}


window.addEventListener("load", start(), false);