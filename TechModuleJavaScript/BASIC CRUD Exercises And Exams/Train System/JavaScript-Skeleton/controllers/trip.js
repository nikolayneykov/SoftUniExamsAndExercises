const Trip = require('../models/Trip');

module.exports = {
    index: (req, res) => {
        Trip.find({}).then(function (trips) {
            res.render('../views/trip/index', { trips });
        });
    },
    createGet: (req, res) => {
        res.render('../views/trip/create');
    },
    createPost: (req, res) => {
        let trip = req.body;
        Trip.create(trip).then(function () {
            res.redirect('/');
        });
    },
    editGet: (req, res) => {
        let id = req.params.id;
        Trip.findById(id).then(function (trip) {
            let origin = trip.origin;
            let destination = trip.destination;
            let business = trip.business;
            let economy = trip.economy;
            res.render('../views/trip/edit', { origin, destination, business, economy });
        });
    },
    editPost: (req, res) => {
        let id = req.params.id;
        let newTrip = req.body;
        Trip.findByIdAndUpdate(id, newTrip).then(function () {
            res.redirect('/');
        });
    },
    deleteGet: (req, res) => {
        let id = req.params.id;
        Trip.findById(id).then(function (trip) {
            let origin = trip.origin;
            let destination = trip.destination;
            let business = trip.business;
            let economy = trip.economy;
            res.render('../views/trip/delete', { origin, destination, business, economy });
        });
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Trip.findByIdAndRemove(id).then(function () {
            res.redirect('/');
        });
    }
};