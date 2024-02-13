var path = require('path');
var webpack = require('webpack');
var fs = require("fs");

module.exports = {
    context: __dirname,
    entry: ['./src/index.tsx'],
    output: {
        path: __dirname + "/dist",
        filename: 'bundle.js'
    },
    devtool: "source-map",
    target: "electron-main",
    resolve: {
        // Add '.ts' and '.tsx' as resolvable extensions.
        extensions: [".ts", ".tsx", ".js", ".json"]
    },
    plugins: [
        new webpack.ProvidePlugin({
            $: "jquery",
            jQuery: "jquery"
        })
    ],
    externals: {
        nodegit: 'commonjs nodegit',
        "react": "React",
        "react-dom": "ReactDOM"
    },
    module: {
        rules: [
            // All files with a '.ts' or '.tsx' extension will be handled by 'awesome-typescript-loader'.
            {
                test: /\.tsx?$/,
                loader: "awesome-typescript-loader"
            },

            // All output '.js' files will have any sourcemaps re-processed by 'source-map-loader'.
            {
                enforce: "pre",
                test: /\.js$/,
                loader: "source-map-loader"
            },
            {
                test: /\.html$/,
                loader: "file-loader?name=[name].[ext]",
            },
            {
                test: /\.(css)$/,
                use: [{
                    loader: 'style-loader', // inject CSS to pageNPM
                }, {
                    loader: 'css-loader', // translates CSS into CommonJS modules
                }]
            }
            // {
            //     test: /\.png$/,
            //     loader: "url-loader?limit=100000"
            // },
            // {
            //     test: /\.jpg$/,
            //     loader: "file-loader"
            // },
            // {
            //     test: /\.(ttf|eot|svg|woff(2)?)(\?[a-z0-9]+)?$/,
            //     loader: 'file-loader',
            //     options: {
            //         name: 'assets/fonts/[name].[ext]'
            //     }

            // }
        ]
    },
    devServer: {
        historyApiFallback: true
    }
};