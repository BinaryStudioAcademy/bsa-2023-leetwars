FROM node:16
WORKDIR /app
COPY package*.json ./
RUN npm install --ignore-scripts
CMD ["sh", "/LocalVolume/JSTest.sh"]
