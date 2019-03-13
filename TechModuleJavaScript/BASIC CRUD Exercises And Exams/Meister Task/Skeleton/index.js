const express = require('express');
const handlebars = require('express-handlebars');
const bodyParser = require('body-parser');
const env = process.env.NODE_ENV || 'development';

const config = require('./config/config')[env];
require('./config/database')(config);

const app = express();
app.engine('.hbs', handlebars({
  defaultLayout: 'main',
  extname: '.hbs'
}));
app.use(bodyParser.urlencoded({
  extended: true
}));
app.use(express.static('static'));
app.set('view engine', '.hbs');
require('./config/routes')(app);

app.listen(config.port, () => console.log(`Listening on port ${config.port}...`));