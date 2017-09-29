var path = require('path');
var webpack = require('webpack');

module.exports = {
    context: __dirname,
    entry: ['./index.html', './entry.js'],
    output: {
        path: __dirname,
        filename: 'bundle.js'
    },
    target: "electron",
    module: {
        loaders: [
            {
                test: /.js?$/,
                loader: 'babel-loader',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015', 'react']
                }
            },
            {
                test: /\.html$/,
                loader: "file-loader?name=[name].[ext]",
            },
            {
                test: /\.css$/,
                loader: "style-loader!css-loader"
            },
            {
                test: /\.png$/,
                loader: "url-loader?limit=100000"
            },
            {
                test: /\.jpg$/,
                loader: "file-loader"
            }
        ]
    },
    devServer: {
        historyApiFallback: true
    }
};