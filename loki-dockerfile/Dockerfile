# Use the official InfluxDB image as the base image.
FROM grafana/loki:2.9.4

# Set the working directory
WORKDIR /etc/loki

# Copy the custom Loki config file
COPY ./config/loki-config.yaml /etc/loki/loki-config.yaml

# Ensure correct permissions
USER root
RUN mkdir -p /data/loki && chmod -R 777 /data/loki

# Set non-root user for Azure compatibility
USER 10001

# Expose the correct port
EXPOSE 3100

# Ensure Loki runs with correct arguments
CMD ["/usr/bin/loki", "-config.file=/etc/loki/loki-config.yaml", "-server.http-listen-port=3100"]
