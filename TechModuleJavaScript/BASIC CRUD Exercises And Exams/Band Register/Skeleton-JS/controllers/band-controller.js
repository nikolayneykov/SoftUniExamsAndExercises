const Band = require('../models/Band');

module.exports = {
  getIndex: function (req, res) {
    Band.find({}).then(function (bands) {
      res.render('index', { bands });
    });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let band = req.body;
    Band.create(band).then(function () {
      res.redirect('/');
    });
  },
  getEdit: function (req, res) {
    let id = req.params.id;
    Band.findById(id).then(function (band) {
      res.render('edit', { band });
    });
  },
  postEdit: function (req, res) {
    let id = req.params.id;
    let newBand = req.body;
    Band.findByIdAndUpdate(id, newBand).then(function () {
       res.redirect('/');
    });
  },
  getDelete: function (req, res) {
    let id = req.params.id;
    Band.findById(id).then(function (band) {
      res.render('delete', { band });
    });
  },
  postDelete: function (req, res) {
    let id = req.params.id;
    Band.findByIdAndRemove(id).then(function () {
       res.redirect('/');
    });
  }
};