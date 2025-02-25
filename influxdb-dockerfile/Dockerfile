# Use the official InfluxDB image as the base image.
FROM influxdb:1.8

# Optional: set environment variables for InfluxDB.
ENV INFLUXDB_DB=k6 \
    INFLUXDB_USER=k6 \
    INFLUXDB_USER_PASSWORD=k6password \
    INFLUXDB_ADMIN_USER=admin \
    INFLUXDB_ADMIN_PASSWORD=adminpassword
  
# Define volumes
VOLUME influxdb-data:/var/lib/influxdb

# Optional: Copy a custom configuration file (if needed).
# COPY influxdb.conf /etc/influxdb/influxdb.conf

# Optional: Expose InfluxDB default port (default for InfluxDB 2.x is 8086)
EXPOSE 8086

# Set the entrypoint to start InfluxDB
ENTRYPOINT ["/entrypoint.sh"]
CMD ["influxd"]
