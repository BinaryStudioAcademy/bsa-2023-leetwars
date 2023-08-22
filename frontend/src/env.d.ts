interface ImportMetaEnv {
    /**
   * Built-in environment variable.
   * @see Docs https://github.com/chihab/ngx-env#ng_app_env.
   */
    readonly NG_APP_ENV: string;
    readonly NG_APP_API_KEY: string;
    readonly NG_APP_MESSAGING_SENDER_ID: string;
    readonly NG_APP_ID: string;
    // Add your environment variables below
    // readonly NG_APP_API_URL: string;
    [key: string]: string;
}

interface ImportMeta {
    readonly env: ImportMetaEnv;
}

// If your project references @types/node directly (in you) or indirectly (as in RxJS < 7.6.0),
// you might need to use the following declaration merging.
// declare namespace NodeJS {
//   export interface ProcessEnv {
//     readonly NG_APP_ENV: string;
//     // Add your environment variables below
//   }
// }

// If you're using Angular Universal and process.env notation, you'll need to add the following to your tsconfig.server.json:
/* In your tsconfig.server.json */
// {
//   "extends": "./tsconfig.app.json",
//   ...
//   "exclude": [
//     "src/env.d.ts"
//   ]
// }

/*********************************************************************/
