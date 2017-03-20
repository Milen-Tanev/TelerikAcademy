function solve() {
	// Your classes
	var counter = 0;
	var qualityTypes = ['high', 'mid', 'low'];

	class Product{
		constructor(manufacturer, model, price){
			this.id = counter;
			counter++;

			if(typeof manufacturer !== 'string') {
				throw new Error;
			} else if (manufacturer.length < 1 || manufacturer.length > 20) {
				throw new Error;
			} else {
				this.manufacturer = manufacturer;
			}

			if(typeof model !== 'string') {
				throw new Error;
			} else if (model.length < 1 || model.length > 20) {
				throw new Error;
			} else {
				this.model = model;
			}
			
			if(typeof price !== 'number') {
				throw new Error;
			} else if (+price <= 0) {
				throw new Error;
			} else {
				this.price = +price;
			}
		}
		getLabel(){
			return '';
		}
	}

	class SmartPhone extends Product {
		constructor(manufacturer, model, price, screenSize, operatingSystem) {
			super(manufacturer, model, price);
			
			if(typeof screenSize !== 'number') {
				throw new Error;
			} else if (+screenSize <= 0) {
				throw new Error;
			} else {
				this.screenSize = +screenSize;
			}

			if(typeof operatingSystem !== 'string') {
				throw new Error;
			} else if (operatingSystem.length < 1 || operatingSystem.length > 10) {
				throw new Error;
			} else {
				this.operatingSystem = operatingSystem;
			}
		}

		getLabel() {
			return 'SmartPhone - ' + this.manufacturer + ' ' + this.model + ' - **' + this.price + '**';
		}
	}

	class Charger extends Product {
		constructor(manufacturer, model, price, outputVoltage, outputCurrent) {
			super(manufacturer, model, price);

			if(typeof outputVoltage !== 'number') {
				throw new Error;
			} else if (+outputVoltage < 5 || +outputVoltage > 20) {
				throw new Error;
			} else {
				this.outputVoltage = +outputVoltage;
			}

			if(typeof outputCurrent !== 'number') {
				throw new Error;
			} else if (+outputCurrent < 100 || +outputCurrent > 3000) {
				throw new Error;
			} else {
				this.outputCurrent = +outputCurrent;
			}
		}

		getLabel() {
			return 'Charger - ' + this.manufacturer + ' ' + this.model + ' - **' + this.price + '**';
		}
	}

	class Headphones extends Product {
		constructor(manufacturer, model, price, quality, hasMicrophone) {

			super(manufacturer, model, price);

			if(typeof quality !== 'string') {
				throw new Error;
			} else if (qualityTypes.indexOf(quality) < 0) {
				throw new Error;
			} else {
				this.quality = quality;
			}

			if(hasMicrophone) {
				this.hasMicrophone = true;
			} else {
				this.hasMicrophone = false;
			}
		}

		getLabel() {
			return 'Headphones - ' + this.manufacturer + ' ' + this.model + ' - **' + this.price + '**';
		}
	}

	class Router extends Product {
		constructor(manufacturer, model, price, wifiRange, lanPorts) {
			super(manufacturer, model, price);
			
			if(typeof wifiRange !== 'number') {
				throw new Error;
			} else if (+wifiRange <= 0) {
				throw new Error;
			} else {
				this.wifiRange = +wifiRange;
			}

			if(typeof lanPorts !== 'number') {
				throw new Error;
			} else if (+lanPorts <= 0) {
				throw new Error;
			} else {
				if(+lanPorts === parseInt(+lanPorts, 10)){
					this.lanPorts = +lanPorts;
				} else {
					throw new Error;
				}
			}
		}

		getLabel() {
			return 'Router - ' + this.manufacturer + ' ' + this.model + ' - '  + '**' + this.price + '**';
		}
	}


	class HardwareStore {
		constructor(name) {
			if(typeof name !== 'string') {
				throw new Error;
			} else if (name.length < 1 || name.length > 20) {
				throw new Error;
			} else {
				this.name = name;
			}
			this.money = 0;

			this.products = [];
		}
		
		stock(product, quantity) {
			
			if(!product) {
				throw new Error;
			} else if(!(product instanceof Product)) {
				throw new Error;
			}

			if(typeof quantity !== 'number') {
				throw new Error;
			} else if (+quantity <= 0) {
				throw new Error;
			} else {
				if(+quantity === parseInt(+quantity, 10)){
					quantity = +quantity;
				} else {
					throw new Error;
				}
			}

			this.products.push({
				product: product,
				quantity: quantity
			});

			return this;
		}

		sell(productId, quantity) { 
			
			if(typeof quantity !== 'number') {
				throw new Error;
			} else if (+quantity <= 0) {
				throw new Error;
			} else {
				if(+quantity === parseInt(+quantity, 10)){
					quantity = +quantity;
				} else {
					throw new Error;
				}
			}

			let index = this.products.findIndex(x => x.product.id === +productId);

			if (index < 0) {
				throw new Error;
			} else {
				if (this.products[index].quantity < quantity) {
					throw new Error;
				} else {
					this.money += (this.products[index].product.price * quantity);
					this.products[index].quantity -= quantity;

					if(this.products[index].quantity === 0) {
						this.products.splice(index, 1);
						counter = index;
					}
				}
			}

			return this;
		}

		getSold() {
			return this.money;
		}
		
		search(options) {
			let result = [];

			if(typeof options !== 'object') {

				let pattern = options.toLowerCase();

				result = this.products.slice().filter(x => ((x.product.manufacturer.toLowerCase().indexOf(pattern) >= 0) || x.product.model.toLowerCase().indexOf(pattern) >= 0));
			} else {
				let currentResult = [];
				if(options.manufacturerPattern){
					currentResult = (this.products.slice()
						.filter(x => x.product.manufacturer.indexOf(options.manufacturerPattern) >= 0));
					
					result.push.apply(result, currentResult);
				}
				if(options.modelPattern) {
					currentResult = (this.products.slice()
						.filter(x => x.product.model.indexOf(options.modelPattern) >= 0));
					result.push.apply(result, currentResult);
				} 
				if(options.type) {
					currentResult = (this.products.slice()
						.filter(x => typeof x.product === options.type));
					result.push.apply(result, currentResult);
				} 
				if(options.minPrice) {
					currentResult = (this.products.slice()
						.filter(x => x.product.price >= +options.minPrice));
					result.push.apply(result, currentResult);
				} 
				if(options.maxPrice) {
					currentResult = (this.products.slice()
						.filter(x => x.product.price <= +options.maxPrice));
					result.push.apply(result, currentResult);
				}
			}
			result = result.filter(function(item, pos){
				return result.indexOf(item) === pos;
			});

			return result;
			
		}
	}


	return {
		getSmartPhone(manufacturer, model, price, screenSize, operatingSystem) {
			return new SmartPhone(manufacturer, model, price, screenSize, operatingSystem);
		},
		getCharger(manufacturer, model, price, outputVoltage, outputCurrent) {
			return new Charger(manufacturer, model, price, outputVoltage, outputCurrent);
		},
		getRouter(manufacturer, model, price, wifiRange, lanPorts) {
			return new Router(manufacturer, model, price, wifiRange, lanPorts);
		},
		getHeadphones(manufacturer, model, price, quality, hasMicrophone) {
			return new Headphones(manufacturer, model, price, quality, hasMicrophone);
		},
		getHardwareStore(name) {
			return new HardwareStore(name);
		}
	};
}

// Submit the code above this line in bgcoder.com
module.exports = solve; // DO NOT SUBMIT THIS LINE
