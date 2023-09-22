interface ImportMetaEnv {
    /**
   * Built-in environment variable.
   * @see Docs https://github.com/chihab/ngx-env#ng_app_env.
   */
    readonly NG_APP_ENV: string;
    readonly NG_APP_FIREBASE_API_KEY: string;
    readonly NG_APP_FIREBASE_MESSAGING_SENDER_ID: string;
    readonly NG_APP_FIREBASE_APP_ID: string;
    // Add your environment variables below
    // readonly NG_APP_API_URL: string;
    [key: string]: string;
}
