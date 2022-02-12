const path = require('path');
//const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry: 
    {
        index:'./src/index.js',
        style:'./src/style.js'
    },
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, 'wwwroot'),
    },
    module: {
        rules: [
            {
                test: /\.css$/i,
                use: ['style-loader', 'css-loader'],
            },
        ],
    },
};