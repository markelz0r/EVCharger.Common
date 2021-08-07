FROM postgres

ENV POSTGRES_USER evdb
ENV POSTGRES_PASSWORD docker
ENV POSTGRES_DB EVCharger
ENV POSTGRES_HOST=evcharger-db

COPY mydb.sql /docker-entrypoint-initdb.d/