const Product = require('../models/product');

module.exports = {
  getIndex: function (req, res) {
    getAll().then((products) => {
      res.render('index', { products });
    });
  },
  getCreate: function (req, res) {
    res.render('create');
  },
  postCreate: function (req, res) {
    let product = req.body;
    addProduct(product).then(() => {
      res.redirect('/');
    });
  },
  getEdit: function (req, res) {
    let id = req.params.id;
    findById(id).then((product) => {
      res.render('edit', { product });
    });
  },
  postEdit: function (req, res) {
    let id = req.params.id;
    let newProduct = req.body;
    editProduct(id, newProduct).then(() => {
      res.redirect('/');
    });
  },
  getDelete: function (req, res) {
    let id = req.params.id;
    res.render('delete', { id });
  },
  postDelete: function (req, res) {
    let id = req.params.id;
    deleteProduct(id).then(() => {
      res.redirect('/');
    });
  }
};

function getAll() {
  return Product.find({});
}

function addProduct(product) {
  return Product.create(product);
}

function findById(id) {
  return Product.findById(id);
}

function editProduct(id, newProduct) {
  return Product.findByIdAndUpdate(id, newProduct);
}

function deleteProduct(id) {
  return Product.findByIdAndDelete(id);
}