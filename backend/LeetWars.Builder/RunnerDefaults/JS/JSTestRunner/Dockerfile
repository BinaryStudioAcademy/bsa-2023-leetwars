FROM node:16
WORKDIR /app
COPY package*.json ./
RUN npm install --ignore-scripts
COPY JsTest.sh ./
CMD ["sh", "./JsTest.sh"]
