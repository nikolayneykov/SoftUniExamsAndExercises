const Product = require('../models/Product');

module.exports = {
  getIndex: function (req, res) {
    Product.find({}).then(function (products) {
      res.render('index', { products });
    });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let product = req.body;
    Product.create(product).then(function () {
      res.redirect('/');
    });
  },
  getEdit: function (req, res) {
    let id = req.params.id;
    Product.findById(id).then(function (product) {
      res.render('edit', { product });
    });
  },
  postEdit: function (req, res) {
    let id = req.params.id;
    let newProduct = req.body;
    Product.findByIdAndUpdate(id, newProduct).then(function () {
       res.redirect('/');
    });
  },
  getDelete: function (req, res) {
    let id = req.params.id;
    res.render('delete',{id});
  },
  postDelete: function (req, res) {
    let id = req.params.id;
    Product.findByIdAndRemove(id).then(function () {
       res.redirect('/');
    });
  }
};