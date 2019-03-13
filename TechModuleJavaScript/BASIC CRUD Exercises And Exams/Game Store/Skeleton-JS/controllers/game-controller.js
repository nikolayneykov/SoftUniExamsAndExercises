const Game = require('../models/Game');

module.exports = {
  getIndex: function (req, res) {
    Game.find({}).then(function (games) {
      res.render('index', { games });
    });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let game = req.body;
    Game.create(game).then(function () {
      res.redirect('/');
    });
  },
  getEdit: function (req, res) {
    let id = req.params.id;
    Game.findById(id).then(function (game) {
      res.render('edit', { game });
    });
  },
  postEdit: function (req, res) {
    let id = req.params.id;
    let newGame = req.body;
    Game.findByIdAndUpdate(id, newGame).then(function () {
       res.redirect('/');
    });
  },
  getDelete: function (req, res) {
    let id = req.params.id;
    Game.findById(id).then(function (game) {
      res.render('delete', { game });
    });
  },
  postDelete: function (req, res) {
    let id = req.params.id;
    Game.findByIdAndRemove(id).then(function () {
       res.redirect('/');
    });
  }
};