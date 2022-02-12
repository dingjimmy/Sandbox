const path = require('path');
const HtmlWebpackPlugin = require('html-webpack-plugin');

module.exports = {
    entry: 
    {
        index:'./src/index.js',
        style:'./src/style.js'
    },
    output: {
        filename: '[name].bundle.js',
        path: path.resolve(__dirname, 'wwwroot'),
        clean: true
    },
    module: {
        rules: [
            {
                test: /\.css$/i,
                use: ['style-loader', 'css-loader'],
            },
        ],
    },
    plugins:[
        new HtmlWebpackPlugin({
            title: 'Vanilla Web App (Auto Generated from Template)',
            template: 'src/index.html'
        })
    ]
};