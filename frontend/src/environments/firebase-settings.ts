export const firebaseSettings = {
    firebaseConfig: {
        apiKey: import.meta.env.NG_APP_FIREBASE_API_KEY,
        authDomain: 'leetwars.firebaseapp.com',
        projectId: 'leetwars',
        storageBucket: 'leetwars.appspot.com',
        messagingSenderId: import.meta.env.NG_APP_FIREBASE_MESSAGING_SENDER_ID,
        appId: import.meta.env.NG_APP_FIREBASE_APP_ID,
    },
};
